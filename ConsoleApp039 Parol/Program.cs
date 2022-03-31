// Задача 6. На вход подаётся число n > 4, указывающее длину пароля.
// Создайте метод, генерирующий пароль заданной длины. 
// В пароле обязательно использовать цифру, букву и специальный знак.
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 6 Доп ================");
            Console.Write("Введите длину пароля более 4 = ");
            int number = Convert.ToInt32(Console.ReadLine());
            char[] numb_array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] letter1_array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] letter2_array = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] simbol_array = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '-', '*', '/', '.', ',', ';', ':' };

            char[] Sum_Arrays(char[] array1, char[] array2) //Метод объединения массивов
            {
                char[] array3 = new char[array1.Length + array2.Length];
                for (int i = 0; i < array1.Length; i++) array3[i] = array1[i];
                for (int j = 0; j < array2.Length; j++) array3[array1.Length + j] = array2[j];
                return array3;
            }
            char[] num_let1_array = Sum_Arrays(numb_array, letter1_array);
            char[] num_let1__let2_array = Sum_Arrays(num_let1_array, letter2_array);
            char[] num_let1__let2_sym_array = Sum_Arrays(num_let1__let2_array, simbol_array);

            Random rand = new Random();
            for (int i = 0; i < number; i++)
            {
                int count = rand.Next(num_let1__let2_sym_array.Length);
                Console.Write(num_let1__let2_sym_array[count]);
            }
            Console.WriteLine("");
            Console.WriteLine("========================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}