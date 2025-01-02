using NimbusClassLibrary.Data;
using NimbusClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NimbusClassLibrary.Controller
{
    public class PlaySongController
    {
        private Song _currentSong;
        private LinkedListNode<Song> _currentSongNode;

        public PlaySongController()
        {
            //LoadSongsFromDB();
        }
        // Selects a song to play from the current queue
        public void SelectSong(Song song)
        {
            if (song == null || !Helpers.GlobalLibraries.Playing_Song.Contains(song))
            {
                throw new Exception("Song not found in the current queue.");
            }

            _currentSong = song;
            _currentSongNode = Helpers.GlobalLibraries.Playing_Song.Find(song);
        }

        // Inserts a song into the stack of previously played songs
        public void InsertToPreviousSong(Song song)
        {
            if (song != null)
            {
                Helpers.GlobalLibraries.Previous_Songs.Push(song);
            }
        }

        // Retrieves the most recently played song from the stack
        public Song GetPreviousSong()
        {
            if (Helpers.GlobalLibraries.Previous_Songs.Count > 0)
            {
                return Helpers.GlobalLibraries.Previous_Songs.Pop();
            }
            else
            {
                throw new Exception("No previous songs available.");
            }
        }

        // Plays the next song in the queue
        public void Next()
        {
            if (_currentSongNode != null)
            {
                InsertToPreviousSong(_currentSongNode.Value);

                if (_currentSongNode.Next != null)
                {
                    _currentSongNode = _currentSongNode.Next;
                    _currentSong = _currentSongNode.Value;
                }
                else
                {
                    throw new Exception("No more songs to play in the queue.");
                }
            }
            else
            {
                throw new Exception("No current song selected or queue is empty.");
            }
        }

        // Initializes the queue with songs from the database (DBContext)
        private void LoadSongsFromDB()
        {
            if (DBContext.songs != null && DBContext.songs.Count > 0)
            {
                foreach (var song in DBContext.songs)
                {
                    Helpers.GlobalLibraries.Playing_Song.AddLast(song);
                }
            }
            else
            {
                throw new Exception("No songs available in the database.");
            }
        }

        // Returns the current queue as a list
        public List<Song> GetQueue()
        {
            return Helpers.GlobalLibraries.Playing_Song.ToList();
        }

        // Returns the stack of previous songs as a list
        public List<Song> GetPreviousSongs()
        {
            return Helpers.GlobalLibraries.Previous_Songs.ToList();
        }
    }
}
