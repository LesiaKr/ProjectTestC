using System;

// �������� � �������� ������ params ������� ���� ����� ���� � ������ �������� � ������ ��������� ������.

namespace Arrays
{
	class Program
	{
		static void ShowArray(string name, params int[] array)
		{
            Console.Write("Hello Dev1");
            Console.Write(name);
				int s = 1;

				for (int i = 0; i < array.Length; i++)
				{
					s = s + i;
					//s = s + array[i];
					Console.Write($"{s} ff");
				}
			}

			static void Main()
			{
				ShowArray("Numbers: ", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
				Console.Write("Hello");
				// Delay.
				Console.ReadKey();
			}
		}
	}
