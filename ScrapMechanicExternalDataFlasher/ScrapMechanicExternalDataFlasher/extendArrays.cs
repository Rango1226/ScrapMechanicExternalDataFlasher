namespace ScrapMechanicExternalDataFlasher
{
    partial class main
    {
        static bool ExtendBoolArray(ref bool[] array, int extensionLenght)
        {
            bool[] temp = new bool[array.Length + extensionLenght];
            for (int index1 = 0; index1 < array.Length; index1++)
            {
                temp[index1] = array[index1];
            }
            array = temp;
            return true;
        }
    }
}
