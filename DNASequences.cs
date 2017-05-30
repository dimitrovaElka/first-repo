using System;

namespace DNASequences
{
    public class DNASequences
    {
        public static void Main()
        {
            int matchSum = int.Parse(Console.ReadLine());
            string nucleicAcid = "ACGT";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        var casing = "X";
                        if ((i + 1) + (j + 1) + (k + 1) >= matchSum)
                        {
                            casing = "O";
                        }
                        var currentNucleicAcidSequence = casing + nucleicAcid[i] + nucleicAcid[j] + nucleicAcid[k] + casing;
                        Console.Write(currentNucleicAcidSequence + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
