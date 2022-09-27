using System.IO;

namespace ScrapMechanicExternalDataFlasher
{
    partial class main
    {
        static void ConvertFileToBoolArray(ref bool[] data, string filePath)
        {
            string[] textFile = File.ReadAllLines(filePath);

            data = new bool[0];

            int index3 = 0;
            for (int index1 = 0; index1 < textFile.GetLength(0); index1++)
            {
                char[] currentLine = textFile[index1].ToCharArray();
                for (int index2 = 0; index2 < currentLine.Length; index2++)
                {
                    if (currentLine[index2] == '1')
                    {
                        ExtendBoolArray(ref data, 1);
                        data[index3] = true;
                        index3++;
                    }
                    else if (currentLine[index2] == '0')
                    {
                        ExtendBoolArray(ref data, 1);
                        data[index3] = false;
                        index3++;
                    }
                }
            }
        }
    }
}
