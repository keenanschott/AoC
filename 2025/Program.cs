class AoC {
    static void Main(string[] args) {
        List<string> lines = [.. File.ReadAllLines("../aoc.in")];
        DayOne.Solution(lines);
    }
}