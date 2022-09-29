class Board {

    List<string> spaces = new List<string>();

    public Board() {
        for (int i = 1; i <= 9; i++) {
            spaces.Add(i.ToString());
        }
    }

    public bool IsPlayerWinner(string player) {
        bool isWinner = false;

        if ((board[0] == player && board[1] == player && board[2] == player)
            || (board[3] == player && board[4] == player && board[5] == player)
            || (board[6] == player && board[7] == player && board[8] == player)
            || (board[0] == player && board[3] == player && board[6] == player)
            || (board[1] == player && board[4] == player && board[7] == player)
            || (board[2] == player && board[5] == player && board[8] == player)
            || (board[0] == player && board[4] == player && board[8] == player)
            || (board[2] == player && board[4] == player && board[6] == player)
            )
        {
            isWinner = true;
        }

        return isWinner; 
    }

    public bool ContainsUnclaimedSpaces() {
        // If there is a digit, there are still moves to be made.
        bool foundDigit = false;

        foreach (string value in spaces)
        {
            if (char.IsDigit(value[0]))
            {
                foundDigit = true;
                break;
            }
        }

        return !foundDigit;
    }
}