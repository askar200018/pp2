using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarMan
{
    //создаем новый класс

    class FarManager

    {//с параметрами: 

        public int cursor;//положение курсора

        public string path;//ссылка на основную папку

        public int size;//количество элементов в директории

        public bool ok;//необходимость показывать скрытые папки

        DirectoryInfo directory = null;//директорий

        FileSystemInfo currentFs = null;//текущий файл/директорий



        public FarManager()//пустой конструктор

        {

            cursor = 0;//курсор всегда стоит на начале

        }



        public FarManager(string path)//конструктор: вводим путь

        {

            this.path = path;

            cursor = 0;//курсор так же на нуле

            directory = new DirectoryInfo(path);//открываем новый директорий по заданному пути

            size = directory.GetFileSystemInfos().Length;//вычисляем количество элементов в директории

            ok = true;//по умолчанию скрытые файлы отображаются

        }



        public void Up()//функция, чтобы листать вверх

        {

            cursor--;//следовательно курсор будет уменьшаться

            if (cursor < 0) cursor = size - 1;//и идти по кругу, достигнув края

        }

        public void Down()//аналогично вниз

        {

            cursor++;//курсор увеличивается

            if (cursor == size) cursor = 0;//и вновь возвращается на первый элемент, после последнего

        }

        public void Left()//стрелка влево

        {

            ok = false;//скрытые файлы не отображаются

            cursor = 0;

        }

        public void Right()//стрелка вправо

        {

            ok = true;//отображаются скрытые файлы

            cursor = 0;//курсор всегда на первом элементе

        }





        public void Color(FileSystemInfo fs, int index)//функция определяет окрашивание

        {//у каждой папки/директория свой индекс

            if (cursor == index)//если курсор совпадет с ним

            {//выделяем

                Console.BackgroundColor = ConsoleColor.Red;

                Console.ForegroundColor = ConsoleColor.White;

                currentFs = fs;//и это будет текущий файл/директорий

            }
            else

            //в противном случае просто определяем

            if (fs.GetType() == typeof(DirectoryInfo))//директорий это

            {

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.White;

            }
            else

            {//или файл

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.Yellow;

            }//и окрашиваем в соответствующие цвета

        }



        public void CalcSz()//в зависимости от скрытых файлов, размер всегда будет меняться

        {

            directory = new DirectoryInfo(path);

            FileSystemInfo[] fs = directory.GetFileSystemInfos();

            size = fs.Length;

            if (ok == false)//если необходимо скрывать файлы

                for (int i = 0; i < fs.Length; i++)

                    if (fs[i].Name[0] == '.')//количество скрытых файлов (начинающихся с точки)

                        size--;//отнимаем от размерности массива элементов

        }



        public void Show()//функция будет выводить имя элемента

        {

            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();//очищаем фон

            directory = new DirectoryInfo(path);

            FileSystemInfo[] fs = directory.GetFileSystemInfos();

            for (int i = 0, k = 0; i < fs.Length; i++)//проверяем каждый элемент массива

            {

                if (ok == false && fs[i].Name[0] == '.')//если он скрытый и нам не нужно его отображать

                {

                    continue;//продолжаем

                }//иначе

                Color(fs[i], k);//определяем цвет с помощью функции и индекса

                Console.Write(k + 1); Console.Write('.');//выводим нумерацию

                Console.WriteLine(fs[i].Name);//и имя элемента

                k++;//отдельный счетчик для нумерации

            }

        }



        public void Start()//функция для запуска реагирует на нажатия пользователем клавиши

        {

            ConsoleKeyInfo CK = Console.ReadKey();

            while (CK.Key != ConsoleKey.Escape)//пока пользователь не выйдет из консоли

            {

                CalcSz();//считаем размерность

                Show();//отображаем список

                CK = Console.ReadKey();//ждем команды

                if (CK.Key == ConsoleKey.UpArrow) Up();

                if (CK.Key == ConsoleKey.DownArrow) Down();

                if (CK.Key == ConsoleKey.LeftArrow) Left();

                if (CK.Key == ConsoleKey.RightArrow) Right();

                //при нажатии определенных клавиш вызываем соответствующие функции

                if (CK.Key == ConsoleKey.Enter)//при нажатии Enter

                {

                    if (currentFs.GetType() == typeof(DirectoryInfo))//если нажали на папку

                    {

                        cursor = 0;

                        path = currentFs.FullName;//программа начнет работать внутри этой папки

                    }

                    else

                    {//если это файл

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.Clear();//очищаем экран

                        string path1 = currentFs.FullName;//определяем путь к текущему файлу

                        StreamReader sr = new StreamReader(path1);

                        string s1 = sr.ReadToEnd();//считываем

                        sr.Close();

                        Console.Write(s1);//выводим на него содержимое файла

                        Console.ReadKey();//ждем нажатия клавиши

                    }

                }

                if (CK.Key == ConsoleKey.Backspace)//если нажали Backspace

                {

                    cursor = 0;

                    path = directory.Parent.FullName;//перемещаемся в предыдущую папку

                }

                if (CK.Key == ConsoleKey.Delete)//если нажали Delete

                {

                    string path1 = currentFs.FullName;//определяем путь к текущей папке/файлу

                    if (currentFs.GetType() == typeof(FileInfo))//если это файл

                    {

                        File.Delete(path1);//удаляем

                    }

                    if (currentFs.GetType() == typeof(DirectoryInfo))//если папка

                    {

                        Directory.Delete(path1);//используем другую функцию

                    }

                }

                if (CK.Key == ConsoleKey.Tab)//если пользователь нажмет Tab, значит он хочет переименовать 

                {

                    string path1 = directory.FullName;//фиксируем путь к текущей папке

                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.Clear();//очищаем консоль

                    string name = Console.ReadLine();//вводим новое имя элемента



                    if (currentFs.GetType() == typeof(FileInfo))//если это файл

                    {

                        string sourcefile = currentFs.FullName;//первоначальный файл мы

                        string destfile = Path.Combine(path1, name);

                        File.Move(sourcefile, destfile);//преобразуем во второй

                    }

                    else

                    if (currentFs.GetType() == typeof(DirectoryInfo))//если папка

                    {

                        string sourcedir = currentFs.FullName;

                        string destdir = Path.Combine(path1, name);//к ссылке папки добавляем имя элемента

                        Directory.Move(sourcedir, destdir);

                    }//получается, что мы на самом деле копируем старый элемент в новый, изменяя название



                }

            }

        }



    }



    class Program

    {

        static void Main(string[] args)

        {

            string path = @"C:\Users\Аскар\Documents\pp1";

            FarManager FarManager = new FarManager(path);

            FarManager.Start();

        }

    }
}
