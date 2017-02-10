using System;
using System.Collections.Generic;

namespace Library.Objects
{
    public class Genre
    {
        public Genre(string genreName)
        {
            _genreName = genreName;
        }

        public static Dictionary<string, List<Album>> _genreDictionary = new Dictionary<string, List<Album>> ();

        private static List<Genre> _genreList = new List<Genre> {};

        private string  _genreName;
        private List<Album> _genreAlbums = new List<Album> {};


        public static Dictionary<string, List<Album>> GetGenreDictionary()
        {
            return _genreDictionary;
        }
        public static void AlbumGenreSave(Album newAlbum, Genre currentGenre)
        {
            if (_genreDictionary.ContainsKey(currentGenre.GetGenreName()))
            {
                _genreDictionary[currentGenre.GetGenreName()].Add(newAlbum);
            }
            else
            {
                currentGenre.SaveGenreAlbum(newAlbum);
                _genreDictionary.Add(currentGenre.GetGenreName(), currentGenre.GetGenreAlbums());
            }
        }
        public string GetGenreName()
        {
            return _genreName;
        }
        public void SetGenreName(string newGenre)
        {
            _genreName = newGenre;
        }
        public List<Album> GetGenreAlbums()
        {
            return _genreAlbums;
        }
        public void SaveGenreAlbum(Album newAlbum)
        {
            _genreAlbums.Add(newAlbum);
        }
        public static List<Genre> GetGenreList()
        {
            return _genreList;
        }
        public static void SaveGenre(Genre newGenre)
        {
            _genreList.Add(newGenre);
        }
    }

    public class Album
    {
        private static List<Album> _albumList = new List<Album> {};

        private string  _artist;
        private string  _albumName;
        private int  _year;
        private string  _genre;
        private Dictionary<int, string> _trackList;

        public Album (string artist, string albumName, int year, string genre)
        {
            _artist = artist;
            _albumName = albumName;
            _year = year;
            _genre = genre;
            _albumList.Add(this);
        }

        public string GetArtist()
        {
            return _artist;
        }
        public void SetArtist(string artist)
        {
            _artist = artist;
        }
        public string GetAlbumName()
        {
            return _albumName;
        }
        public void SetAlbumName(string albumName)
        {
            _albumName = albumName;
        }
        public int GetYear()
        {
            return _year;
        }
        public void SetYear(int year)
        {
            _year = year;
        }
        public string GetGenre()
        {
            return _genre;
        }
        public void SetGenre(string genre)
        {
            _genre = genre;
        }
        public static List<Album> GetAlbums()
        {
            return _albumList;
        }
        public static void SaveAlbum(Album newAlbum)
        {
            _albumList.Add(newAlbum);
        }
        public Dictionary<int, string> GetTrackList()
        {
            return _trackList;
        }
        public void SetTrackList(Dictionary<int, string> trackList)
        {
            _trackList = trackList;
        }
    }
}
