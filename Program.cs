using calendar_deneme.Entities;

Console.WriteLine("Calendar App");


Meeting meeting1 = new()
{
    Id = Guid.NewGuid(),
    Title = "Yetgen Toplantı",
    Details = new List<string> { 
        "katılımcılar",
        "butce",
        "diğer toplantılar"},
    StartTime = new DateTime(2023,09,18,19,00,00),
    FinishTime = new DateTime(2023,09,18,20,00,00),
    Guests = new() { "buse@deneme.com", "ilayda@deneme.com"}
};

ToDo todo1 = new()
{
    Id = Guid.NewGuid(),
    Title = "Geri Bildirimler",
    Details = new List<string> { 
        "değerlendirme sonuçları",
        "grafikler"},
    StartTime = new DateTime(2023, 09, 18, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 22, 00, 00),
    Importance = "high priority"
};

meeting1.GetNotification();
todo1.GetNotification();





   
