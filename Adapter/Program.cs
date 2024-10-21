using Adapter;


ComputerGame minecraftGame = new("Minecraft", PegiAgeRating.P7, 20, 1024, 10, 2, 2, 1.5);
PCGame minecraftPcGame = new GameAdapter(minecraftGame);
Console.WriteLine($"Игра: {minecraftPcGame.getTitle()}\n" +
    $"Возраст: {minecraftPcGame.getPegiAllowedAge()}\n" +
    $"Triple-A: {minecraftPcGame.isTripleAGame()}");
PrintRequirements(minecraftPcGame.getRequirements());

void PrintRequirements(Requirements req) =>
    Console.WriteLine($"Системные требования: " +
    $"GPU: {req.getGpuGb()}GB, " +
    $"HDD: {req.getHDDGb()}GB, " +
    $"RAM: {req.getRAMGb()}GB, " +
    $"CPU: {req.getCpuGhz()}GHz, " +
    $"Cores: {req.getCoresNum()}");