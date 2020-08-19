public class GCD
{
    public static int generalizedGCD(int num, int[] arr)
    {
        bool contrl = false;
        int[] newArr = null;

        newArr = selectionSort(arr);

        int numMax = newArr[newArr.Length - 1];

        while (!contrl)
        {
            contrl = true;
            for (int i = 0; i < num; i++)
            {
                if (newArr[i] % numMax != 0)
                {
                    contrl = false;
                    break;
                }
            }
            if (!contrl)
                numMax -= 1;
        };
        return numMax;
    }

    public static int[] selectionSort(int[] vetor)
    {
        int min, aux;
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < vetor.Length; j++)
                if (vetor[j] < vetor[min])
                    min = j;
            if (min != i)
            {
                aux = vetor[min];
                vetor[min] = vetor[i];
                vetor[i] = aux;
            }
        }
        return vetor;
    }
}