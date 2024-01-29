﻿namespace SdrsDecoder.Cli
{
    using System;
    using System.Collections.Generic;
    using NAudio.Wave;
    using SdrsDecoder.Pocsag;
    using SdrsDecoder.Support;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var source = "SDRSharp_20210414_211225Z_156150138Hz_AF.wav";

                if (args.Length > 0)
                {
                    source = args[0];
                }

                Console.WriteLine($"Source: {source}, press any key to process.");

                //Console.ReadKey(true);

                var file = new NAudio.Wave.WaveFileReader(source);

                var samples = new List<float>();

                while (true)
                {
                    var frame = file.ReadNextSampleFrame();

                    if (frame == null)
                    {
                        break;
                    }

                    var s = frame[0];

                    samples.Add(s);
                }

                var baud = 512;

                //var sr = file.WaveFormat.SampleRate;

                //var i = 256;
                //var d = 1875;

                //var isr = sr * i;

                //var interpolator = new Interpolator(i);
                //var interpd = interpolator.Process(samples.ToArray());

                //using (var writer = new WaveFileWriter("interpd.wav", new WaveFormat(isr, 1)))
                //{
                //    foreach (var s in interpd)
                //    {
                //        writer.WriteSample(s);
                //    }
                //}

                //var filter = new ChebyFilter(512, 1, isr);
                //var filterd = filter.Process(interpd);

                //using (var writer = new WaveFileWriter("filterd.wav", new WaveFormat(isr, 1)))
                //{
                //    foreach (var s in filterd)
                //    {
                //        writer.WriteSample(s);
                //    }
                //}


                //var dsr = isr / d;

                //var decim = new Decimator(d);
                //var decimd = decim.Process(filterd);

                //using (var writer = new WaveFileWriter("decimd.wav", new WaveFormat(dsr, 1)))
                //{
                //    foreach (var s in decimd)
                //    {
                //        writer.WriteSample(s);
                //    }
                //}

                var messageCount = 0f;
                var successCount = 0f;

                var chain = new PocsagChain(
                    baud,
                    file.WaveFormat.SampleRate,
                    (message) =>
                    {
                        messageCount += 1;

                        if (!message.HasErrors)
                        {
                            successCount += 1;
                        }

                        Console.WriteLine(message.ErrorText + (message.HasErrors ? "" : " " + message.TypeText + " " + message.Payload));
                    });

                var debug = new List<float>();
                void ws(float sample) { debug.Add(sample); }

                chain.Process(samples.ToArray(), writeSample: ws);

                Console.WriteLine($"{successCount} / {messageCount} = {successCount / messageCount * 100}%");

                using (var writer = new WaveFileWriter("debug.wav", new WaveFormat(chain.Rv.dsr, 4)))
                {
                    foreach (var ss in debug.ToArray())
                    {
                        writer.WriteSample(ss);
                    }
                }
            }
            catch (Exception exception)
            {
                Log.LogException(exception);
                Console.WriteLine($"Exception: {exception.Message}");
            }

            Console.WriteLine("Done.");
            Console.ReadKey(true);
        }
    }
}
