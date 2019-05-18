using System;

namespace KK
{
    class KK
    {
        private char[,] _board;
        private bool _turn;
        private Tuple<int, int> _lastMove;
        private int _numberOfMoves;

        public KK()
        {
            Random gen = new Random();

            _board = new char[3, 3];
            _turn = gen.Next(100) <= 50;
            _numberOfMoves = 0;

            for (int r = 0; r < 3; ++r)
            {
                for (int c = 0; c < 3; ++c)
                {
                    _board[r, c] = '.';
                }
            }
        }

        private char _getFigure()
        {
            if (_turn)
            {
                return 'O';
            }

            return 'X';
        }

        private bool _isWinCondition()
        {
            bool f = true;
            char first = '.';

            // checking rows
            for(int r = 0; r < 3; ++r)
            {
                first = _board[r, 0];
                f = first != '.';
                for (int c = 1; f && c < 3; ++c)
                {
                    if (_board[r, c] != first || _board[r, c] == '.')
                    {
                        f = false;
                    }
                }

                if (f) return f;
            }

            // checking cols
            for (int c = 0; c < 3; ++c)
            {
                first = _board[0, c];
                f = first != '.';
                for (int r = 1; f && r < 3; ++r)
                {
                    if (_board[r, c] != first || _board[r, c] == '.')
                    {
                        f = false;
                    }
                }

                if (f) return f;
            }

            // checking axis
            first = _board[0, 0];
            f = first != '.';
            for (int i = 1; f && i < 3; ++i)
            {
                if (_board[i, i] != first || _board[i, i] == '.')
                {
                    f = false;
                }
            }

            if (f) return f;

            first = _board[0, 2];
            f = first != '.';
            for (int i = 1; f && i < 3; ++i)
            {
                if (_board[i, 2 - i] != first || _board[i, 2 - i] == '.')
                {
                    f = false;
                }
            }

            if (f) return f;

            return false;
        }

        public bool doTurn(int row, int col) // 1, 2, 3
        {
            if (_board[row, col] == 'O' || _board[row, col] == 'X')
            {
                return false;
            }
            else
            {
                _board[row, col] = _getFigure();
                _lastMove = Tuple.Create<int, int>(row, col);
                ++_numberOfMoves;
                _turn = !_turn;
            }

            return true;
        }

        public bool isEnd()
        {
            return _numberOfMoves == 9 || _isWinCondition();
        }

        public char getSymbolAt(int r, int c)
        {
            return _board[r, c];
        }

        public bool whoMoves()
        {
            return _turn;
        }

        public int whoWon()
        {
            if (_isWinCondition())
            {
                if (_turn)
                {
                    return 0;
                } else
                {
                    return 1;
                }
            }
            else
            {
                return 2;
            }
        }

        public override String ToString()
        {
            String s = "";

            for (int r = 0; r < 3; ++r)
            {
                for (int c = 0; c < 3; ++c)
                {
                    s += _board[r, c] + " ";  
                }

                s += "\r\n";
            }

            return s;
        }
    }
}
