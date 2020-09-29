using System;
using System.Collections.Generic;

namespace Secure_User_Database
{
    public class Validator  //this is el menu :p   // Nice info in here... http://www.udb.edu.sv/udb_files/recursos_guias/informatica-ingenieria/programacion-orientada-a-objetos-(ing)/2019/ii/guia-6.pdf
    {
        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 9 });
        private const int MAIN_MENU_EXIT_OPTION = 9;
        List<string> names = new List<string>();
        List<int> ids = new List<int>();
        List<string> claves = new List<string>();



        private int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }
       
       static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];

            arr[i] = arr[j];

            arr[j] = temp;
        }

        static void BubbleSort(int[] numbers)
        {

            for (int i = numbers.Length - 1; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        Swap(numbers, j, j + 1);
                    }
                }
            }
        }
       public void Welcome() {
            Console.WriteLine("---------------Secure User Database-----------");

       }
        public void Registro()
        {  

            Console.WriteLine("\n   Inserte nombre de usuario:");
            string nameTyped = Console.ReadLine();
            names.Add(nameTyped);

            System.Console.WriteLine("Nombre: " + nameTyped);
            //names.SetValue(nameTyped, 0);        --En caso de usar arreglo

            System.Console.WriteLine("\n   Ingrese su Identificador (secuencia de numeros):");
            int idTyped = int.Parse(Console.ReadLine());
            ids.Add(idTyped);
            System.Console.WriteLine("Nombre: " + nameTyped);
            System.Console.WriteLine("ID: " + idTyped);

            System.Console.WriteLine("\n   Ingrese clave numérica (min 5 números y separados por coma ( , )):");  //min 5 números
            string claveTyped = Console.ReadLine();
            claves.Add(claveTyped);
            System.Console.WriteLine("Nombre: " + nameTyped);
            System.Console.WriteLine("ID: " + idTyped);
            System.Console.WriteLine("Clave: " + claveTyped);
            System.Console.WriteLine();

            //TO DO
            //Guardar los datos introducidos en un Objeto Usuario y hacer un arreglo de Objetos Usuario    --Usar Pokedex.cs de referencia

            //Usuario usuarioTyped = new Usuario();

        }

        public void Resumen() {
            System.Console.WriteLine("show resume");   //TO DO
        }

        private void DisplayMainMenuOptions() {
            System.Console.WriteLine("1) Registrar usuario");
            System.Console.WriteLine("2) Mostrar resumen de usuarios");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }
        public void Display() {
            int selectedOption = 0;
            Welcome();

            while (selectedOption != MAIN_MENU_EXIT_OPTION) {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1: //Registro
                        Registro();
                        break;
                    case 2: //Consulta resumen
                        Resumen();
                        break;
                    // default:
                }
            }

            //DisplayByeMessage();
        }
    }
}
