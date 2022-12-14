using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "The Hitchhiker's Guide to the Galaxy",
            Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
            ImageURL= "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
            Price = 9.99m
        },
         new Product
        {
            Id = 2,
            Title = "Ready Player One",
            Description = "Ready Player One is a 2018 American science fiction adventure film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg from a screenplay by Zak Penn and Cline, it stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance. The film is set in 2045, where much of humanity uses the OASIS, a virtual reality simulation, to escape the real world. A teenage orphan finds clues to a contest that promises the ownership of the OASIS to the winner, and he and his allies try to complete it before an evil corporation can do so. ",
            ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
            Price = 7.99m
        },
         new Product
        {
            Id = 3,
            Title = "Nineteen Eighty-Four",
            Description = "Nineteen Eighty-Four is a dystopian social science fiction novel and cautionary tale written by the English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
            ImageURL = "https://m.media-amazon.com/images/P/0451524934.01._SCLZZZZZZZ_SX500_.jpgs",
            Price = 6.99m
        }
    };


    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProduct()
    {
        return Ok(Products);
    }





}

