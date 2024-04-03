public class Solution {
    public bool Exist(char[][] board, string word) {
        var rows = board.Length;
        var cols = board[0].Length;

    var charsused = new List<int[]>();
 
     
     bool backtrack(int r, int c, int i)
    {
        int[] current = {r, c};
        if(i == word.Length) {return true;}

        if(r < 0 ||c < 0 || r >= rows|| c >= cols|| word[i] != board[r][c] || charsused.Any(arr => arr.SequenceEqual(current)))
         {return false;}

       charsused.Add(current);

       var res = false;
        if( backtrack(r+1, c, i+1) ||
            backtrack(r-1, c, i+1) ||
            backtrack(r, c+1, i+1) ||
            backtrack(r,c-1, i+1))
        {res = true;}

        charsused.Remove(current);

       return res;

    }
        for(int r = 0; r < rows; r++){
            for(int c = 0; c< cols; c++){
               var result = backtrack(r,c,0);
               if(result){
                return true;
               }
            }
        }
        return false;
    }
}