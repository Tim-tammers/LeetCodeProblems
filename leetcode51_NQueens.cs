//leetcodeproblem 51 n queens backtracking
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        List<int> col = new List<int>();
        List<int> posdiag = new List<int>(); //r+c
        List<int> negdiag = new List<int>(); //r-c

        IList<IList<string>> result = new List<IList<string>>();
        List<char[]> board = new List<char[]>();
        for(int i = 0; i<n; i++){
            string row = new string('.', n);
            board.Add(row.ToCharArray());
        }
         void backTrack(int r){
            if(r == n){
               var successfulBoard = new List<string>();
                foreach(char[] row in board){
                successfulBoard.Add(new string(row));
                }
                result.Add(successfulBoard);
                return;
            }

                for(int c = 0; c < n; c++){
                    if(col.Contains(c) || posdiag.Contains(r+c) || negdiag.Contains(r-c)){
                        continue;
                    }
                    col.Add(c);
                    posdiag.Add(r+c);
                    negdiag.Add(r-c);
                    board[r][c] = 'Q';

                    backTrack(r+1);

                    col.Remove(c);
                    posdiag.Remove(r+c);
                    negdiag.Remove(r-c);
                    board[r][c] = '.';
                }

            
        }
        backTrack(0);
        return result;

        
        
    }
}