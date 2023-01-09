class Board {

    List<string> spaces = new List<string>();

    public Board() {
        for (int i = 1; i <= 9; i++) {
            spaces.Add(i.ToString());
        }
    }

    public bool IsPlayerWinner(string player) {
        bool isWinner = false;

        if ((spaces[0] == player && spaces[1] == player && spaces[2] == player)
            || (spaces[3] == player && spaces[4] == player && spaces[5] == player)
            || (spaces[6] == player && spaces[7] == player && spaces[8] == player)
            || (spaces[0] == player && spaces[3] == player && spaces[6] == player)
            || (spaces[1] == player && spaces[4] == player && spaces[7] == player)
            || (spaces[2] == player && spaces[5] == player && spaces[8] == player)
            || (spaces[0] == player && spaces[4] == player && spaces[8] == player)
            || (spaces[2] == player && spaces[4] == player && spaces[6] == player)
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