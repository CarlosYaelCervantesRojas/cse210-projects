using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Alma Counsels His Son", "Book of Mormon", 1034);
        Comment c1 = new Comment("Jhon Doria", "Lorem ipsum dolor sit amet consectetur adipiscing elit hac, ultricies congue nostra maecenas habitant semper enim, taciti curabitur bibendum integer tristique aptent augue.");
        Comment c2 = new Comment("Lucia Jones", "Potenti bibendum tincidunt dignissim duis accumsan interdum malesuada luctus magnis nunc tempor, platea dui taciti commodo aliquam justo mus cursus netus a, curae sollicitudin ullamcorper class euismod velit lobortis natoque eros etiam.");
        Comment c3 = new Comment("Martha Smith", "Est morbi iaculis conubia sociis massa mollis vel ultricies, libero auctor posuere eros ridiculus euismod penatibus cursus, hac vestibulum aliquam aptent eget praesent risus.");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        videos.Add(v1);

        Video v2 = new Video("Ammon Serves and Teaches King Lamoni", "Book of Mormon", 1228);
        Comment co1 = new Comment("Luis Diaz", "Turpis rhoncus et cursus tempor ridiculus ad varius aenean venenatis, urna bibendum purus sem vel class integer justo duis orci, convallis feugiat");
        Comment co2 = new Comment("Ramon Perez", "Lacus litora tincidunt tortor risus luctus est facilisis ante in fames, facilisi tempor aptent habitant iaculis quis lacinia interdum.");
        Comment co3 = new Comment("Oscar Torres", "Semper proin donec augue per aliquet euismod hac iaculis, lacus luctus montes inceptos nec sem nibh aliquam quam, facilisi est sollicitudin maecenas elementum odio libero.");
        Comment co4 = new Comment("Roberto Rojas", "Vel pellentesque iaculis donec nascetur litora natoque commodo, ultricies nisl scelerisque lacinia habitant malesuada class");

        v2.AddComment(co1);
        v2.AddComment(co2);
        v2.AddComment(co3);
        v2.AddComment(co4);
        videos.Add(v2);

        Video v3 = new Video("Abinadi Testifies of Jesus Christ", "Book of Mormon", 1538);
        Comment com1 = new Comment("Alberta Julieta", "Proin maecenas ac viverra orci auctor sodales, lacus erat nulla aptent vestibulum metus, senectus venenatis pretium ante aenean.");
        Comment com2 = new Comment("Xavi Simons", "Commodo molestie ultricies eu ut facilisi tempor leo condimentum pharetra, feugiat cursus dictum integer metus fusce sem vulputate, egestas morbi magna sociis aenean eget himenaeos ridiculus.");
        Comment com3 = new Comment("Daniel Olmo", "Sodales vulputate nisi ridiculus nunc ante elementum placerat eget, lacinia dapibus in justo phasellus risus primis.");

        v3.AddComment(com1);
        v3.AddComment(com2);
        v3.AddComment(com3);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine("---------------------------------------------------------");
            video.DisplayVideoInfo();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}