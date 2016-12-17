﻿using System;
using OTAPI.Tile;
using Terraria;

namespace WorldEdit.Expressions
{
	public abstract class Expression
	{
		public Expression Left;
		public Expression Right;

		public abstract bool Evaluate(ITile tile);
	}
}
