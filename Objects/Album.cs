emaNmublausing System;
using System.Collections.Generic;

namespace Album.Object
{
    public class Album
    {
        private string  _artist;
        private string  _albumName;
        private int  _year;
        private string  _genre;
        private Dictionary<int, string> _trackList;

        public Album (string artist, string albumName, int year, string genre, Dictionary<int, string> trackList)
        {
            _artist = artist;
            _albumName = albumName;
            _year = year;
            _genre = genre;
            _trackList = trackList;
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
        public string GetArtist()
        {
            return _artist;
        }
        public void SetArtist(string artist)
        {
            _artist = artist;
        }
        public string GetArtist()
        {
            return _artist;
        }
        public void SetArtist(string artist)
        {
            _artist = artist;
        }
        public string GetArtist()
        {
            return _artist;
        }
        public void SetArtist(string artist)
        {
            _artist = artist;
        }
    }
}
