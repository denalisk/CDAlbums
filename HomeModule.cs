using Nancy;
using System.Collections.Generic;
using Library.Objects;

namespace Library
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["index.cshtml"];
            };
            Post["/add-album"] = _ =>
            {
                string newGenreName = Request.Form["genre"];
                Album newAlbum = new Album
                (
                    Request.Form["artist"],
                    Request.Form["album-name"],
                    Request.Form["year"],
                    newGenreName
                );
                Genre newGenre = new Genre(newGenreName);
                Genre.AlbumGenreSave(newAlbum, newGenre);

                return View["albums.cshtml", Genre.GetGenreDictionary()];
            };
            // PUT ROUTES HERE
        }
    }
}
