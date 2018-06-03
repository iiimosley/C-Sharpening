using System;
using System.Collections.Generic;

namespace tictactoe
{
  class Board
  {
    static string straightLine = new String('-', 11);
    
    public static string CurrentStatus (char[][] Matrix)
    { 
    return $"{Environment.NewLine} {Matrix[0][0]} | {Matrix[0][1]} | {Matrix[0][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {Matrix[1][0]} | {Matrix[1][1]} | {Matrix[1][2]} {Environment.NewLine}{straightLine}{Environment.NewLine} {Matrix[2][0]} | {Matrix[2][1]} | {Matrix[2][2]} {Environment.NewLine}";
    }
  }
}
