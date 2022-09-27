namespace ScrapMechanicExternalDataFlasher
{
    partial class main
    {
        static void Main(string[] args)
        {
            splashscreen();

            string filePath = "";
            bool[] data = new bool[0];

            while(true)
            {
                filePath = GetFilePath();
                ConvertFileToBoolArray(ref data, filePath);
                TransferDataV1(ref data, ref filePath);
            }
        }
    }
}
