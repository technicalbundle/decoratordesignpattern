using System;

namespace DecoratorDesignPattern
{
    class Client
	{
		static void Main(string[] args)
		{
			IRoom basicRoom = new BasicRoom();
			basicRoom.GetRoom();
			Console.WriteLine();

			IRoom executiveRoom = new ExecutiveRoom(basicRoom);
			executiveRoom.GetRoom();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
		}
	}
}


