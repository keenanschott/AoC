class AoC {
    static void Main(string[] args) {
        List<string> lines = [.. File.ReadAllLines("../aoc.in")];
        // DayOne.PartOne(lines);
        // DayOne.PartTwo(lines);
        // DayTwo.PartOne(lines);
        DayTwo.PartTwo(lines);
    }
}