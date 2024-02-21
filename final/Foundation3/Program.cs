using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("2237 Lithia Center Ln", "Valrico", "Florida", "USA");
        Lecture lecture = new Lecture("Love story", "The story is about a couple, Jennifer Cavilleri and Oliver Barret. They meet at the university and they fall in love.", "22/01/2024", "11:00 am", address, "Erich Segal", 25);

        lecture.DisplayStandardDetails();
        lecture.DisplayFullDetails();
        lecture.DisplayShortDescription();


        Address address2 = new Address("104 N Tennessee St", "McKinney", "Texas", "USA");
        Reception reception = new Reception("Parent dances", "When the toasts are complete, it's time to show your parents some love.", "17/09/2024", "7:00 pm", address2, "reception@parents.com");

        reception.DisplayStandardDetails();
        reception.DisplayFullDetails();
        reception.DisplayShortDescription();


        Address address3 = new Address("2801 Candler Rd", "Decatur", "Georgia", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Ballon Stomp", "Water balloon toss is an excellent activity for team building as well as various gatherings.", "28/02/2024", "10:00 am", address3, "75° degrees and sunny");
        outdoorGathering.DisplayStandardDetails();
        outdoorGathering.DisplayFullDetails();
        outdoorGathering.DisplayShortDescription();
    }
}