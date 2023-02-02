
/***************************************************************************

                                 ChessV

                  COPYRIGHT (C) 2012-2017 BY GREG STRONG

This file is part of ChessV.  ChessV is free software; you can redistribute
it and/or modify it under the terms of the GNU General Public License as 
published by the Free Software Foundation, either version 3 of the License, 
or (at your option) any later version.

ChessV is distributed in the hope that it will be useful, but WITHOUT ANY 
WARRANTY; without even the implied warranty of MERCHANTABILITY or 
FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for 
more details; the file 'COPYING' contains the License text, but if for
some reason you need a copy, please visit <http://www.gnu.org/licenses/>.

****************************************************************************/

using System;
using System.Collections.Generic;

namespace ChessV.Games
{
	//**********************************************************************
	//
	//    Skymate
	//
	//    What happens if the design principles of chess are applied to a 10x10 board? Only three adjustments are needed: The next logical piece, an expanded start position and modified step lengths for the pawns. Will it work? 

	[Game("Skymate", typeof(Geometry.Rectangular), 10, 10,
		  XBoardName = "skymate",
		  Invented = "2019",
		  InventedBy = "Ulrich Schwekendiek",
		  Tags = "Chess Variant,Popular")]
	[Appearance(ColorScheme = "Lemon Cappuccino")]
	public class Skymate: Abstract.Generic10x10
	{
		// *** PIECE TYPES *** //

		public PieceType Eagle;


		// *** CONSTRUCTION *** //

		public Skymate(): 
			base
				( /* symmetry = */ new RotationalSymmetry() )
		{
		}


		// *** INITIALIZATION *** //

		#region SetGameVariables
		public override void SetGameVariables()
		{
			base.SetGameVariables();
			Array = "ernbqkbnre/pppppppppp/10/10/10/10/10/10/PPPPPPPPPP/ERNBQKBNRE";
			PromotionRule.Value = "Standard";
			PromotionTypes = "RNBEQ";
			PawnMultipleMove.Value = "Skymate";
			Castling.Value = "Skymate";
			EnPassant = true;
			StalemateResult.Value = "Loss";
		}                    
		#endregion

		#region AddPieceTypes
		public override void AddPieceTypes()
		{
			base.AddPieceTypes();
			AddPieceType( Queen = new Queen( "Queen", "Q", 900, 900 ) );
			AddPieceType( Rook = new Rook( "Rook", "R", 500, 500 ) );
			AddPieceType( Bishop = new Bishop( "Bishop", "B", 300, 300 ) );
			AddPieceType( Knight = new Knight( "Knight", "N", 300, 300 ) );
			AddPieceType( Eagle = new Eagle( "Eagle", "E", 500, 500 ) );
		}
		#endregion
	}
}
