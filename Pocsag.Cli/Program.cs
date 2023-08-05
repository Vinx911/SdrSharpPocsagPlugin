﻿namespace SdrsDecoder.Cli
{
    using System;
    using System.Collections.Generic;
    using SdrsDecoder.Support;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var source = "Flex 1600 001.wav";

                if (args.Length > 0)
                {
                    source = args[0];
                }

                Console.WriteLine($"Source: {source}, press any key to process.");

                Console.ReadKey(true);

                var file = new NAudio.Wave.WaveFileReader(source);

                var samples = new List<float>();

                while (true)
                {
                    var frame = file.ReadNextSampleFrame();

                    if (frame == null)
                    {
                        break;
                    }

                    samples.Add(frame[0]);
                }

                var decodes = 0;

                var pocsagManager =
                    new Manager(
                        file.WaveFormat.SampleRate,
                        (MessageBase message) =>
                        {
                            if (!message.HasErrors)
                            {
                                Console.Write("BAD DECODE:\n");
                            }

                            Console.Write($"{message.Protocol} {message.Address}\n");
                            Console.Write(message.Payload);
                            Console.Write("\n---\n");

                            decodes++;
                        });

                pocsagManager.Process(samples.ToArray());

                Console.WriteLine($"Decodes: {decodes}");
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
