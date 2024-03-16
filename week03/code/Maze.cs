/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
public void MoveLeft() {
        // Check if there's no wall to the left (index 0 in the bool array)
        if (_mazeMap[(_currX, _currY)][0]) {
            // If there's no wall to the left, move left
            _currX--;
            Console.WriteLine("Moved left");
        } else {
            // If there's a wall to the left, display an error message
            Console.WriteLine("Can't go that way!");
        }
}


    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight() {
        // Check if there's no wall to the right (index 1 in the bool array)
        if (_mazeMap[(_currX, _currY)][1]) {
            // If there's no wall to the right, move right
            _currX++;
            Console.WriteLine("Moved right");
        } else {
            // If there's a wall to the left, display an error message
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp() {
        // Check if there's no wall up (index 3 in the bool array)
        if (_mazeMap[(_currX, _currY)][2]) {
            // If there's no wall up, move up
            _currY--;
            Console.WriteLine("Moved up");
        } else {
            // If there's a wall up, display an error message
            Console.WriteLine("Can't go that way!");
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown() {
        // Check if there's no wall down (index 4 in the bool array)
        if (_mazeMap[(_currX, _currY)][3]) {
            // If there's no wall up, move up
            _currY++;
            Console.WriteLine("Moved down");
        } else {
            // If there's a wall up, display an error message
            Console.WriteLine("Can't go that way!");
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}