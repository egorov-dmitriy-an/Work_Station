int[] arr = { 2, 4, 3, 2, 4, 3, 4, 4, 3, 2, 3, 2 };
List<int> list_0 = new List<int>();
int leng =1;
list_0.Add(arr[0]);
Console.Write(list_0[0] + ", ");
    for(int j = 0; j<arr.Length; j++)
    {
        int mod = 0;
        for(int k = 0; k<leng; k++)
        {
            if (arr[j] == list_0[k]) mod = 1;
        }
        if (mod == 0) 
        {
            list_0.Add(arr[j]);
            Console.Write(arr[j] + ", ");
            leng += 1; 
        }
    }
