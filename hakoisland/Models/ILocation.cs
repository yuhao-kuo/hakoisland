using System;

namespace hakoisland.Models
{
	public interface ILocation
	{
		int WorldX { get; }
		int WorldY { get; }
		int X { get; }
		int Y { get; }
	}
}
