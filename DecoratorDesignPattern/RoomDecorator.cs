using System;

namespace DecoratorDesignPattern
{
	/// <summary>
	/// This is the decorator base class that implements the IRoom interface and provides the same functionality 
	/// as of BasicRoom class. The class also accepts the IRoom object in its constructor to maintains a 
	/// reference so that it can provide the extended behavior.
	/// </summary>
	public abstract class RoomDecorator : IRoom
	{
		protected IRoom room;

		public RoomDecorator(IRoom room)
		{
			this.room = room;
		}

		public virtual void GetRoom()
		{
			Console.WriteLine("Basic-Room allotted with free amenities");
		}
	}
}


