namespace CRUDJokeApp.Models
{
    public static class JokeRepository
    {
        private static List<Joke> _jokeList = new List<Joke>()
        {
            new Joke{Id = 1, JokeQuestion = "Why did the computer go to the doctor?", JokeAnswer = "Because it caught a virus!" },
            new Joke{Id = 2, JokeQuestion = "What did the ocean say to the beach?", JokeAnswer = "Nothing, it just waved." },
            new Joke{Id = 3, JokeQuestion = "Why did the picture go to jail?", JokeAnswer = "Because it was framed!" }
        };
        
        public static void AddJoke(Joke joke)
        {
            var maxId = _jokeList.Count;
            joke.Id = maxId + 1;
            _jokeList.Add(joke);
        }
        public static List<Joke> GetJokeList() { return _jokeList; }

        public static Joke? GetJokeById(int jokeId)
        {
            var joke = _jokeList.FirstOrDefault(j => j.Id == jokeId);
            if(joke != null)
            {
                return joke;
            }
            return null;
        }

        public static void UpdateJoke(Joke joke)
        {
            var jokeId = joke.Id;
            var jokeToUpdate = _jokeList.FirstOrDefault(j => j.Id == jokeId);
            if (jokeToUpdate != null)
            {
                jokeToUpdate.JokeQuestion = joke.JokeQuestion;
                jokeToUpdate.JokeAnswer = joke.JokeAnswer;
            }
        }

        public static void DeleteJoke(int jokeId) 
        { 
            var joke = _jokeList.FirstOrDefault(j => j.Id == jokeId);
            if(joke != null)
            {
                _jokeList.Remove(joke);
            }
        }
    }
}
