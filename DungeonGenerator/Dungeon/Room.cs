﻿/*
    Copyright (C) 2015 creepylava

    This file is part of RotMG Dungeon Generator.

    RotMG Dungeon Generator is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/

using System;
using RotMG.Common.Rasterizer;

namespace DungeonGenerator.Dungeon {
	public enum RoomType {
		Normal,
		Begin,
		End,
		Special
	}

	public abstract class Room {
		public abstract RoomType Type { get; }
		public abstract int Width { get; }
		public abstract int Height { get; }

		public Point Pos { get; }

		public Rect Bounds { get { return new Rect(Pos.X, Pos.Y, Pos.X + Width, Pos.Y + Height); } }
	}
}