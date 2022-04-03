namespace Sandbox;

public class Sandcastle
{
    public Tower[] Towers { get; set; }
    public int NumberOfTowers => Towers.Length;

    public Sandcastle(Tower[] towers)
    {
        Towers = towers ?? throw new ArgumentNullException(nameof(towers));
    }
}