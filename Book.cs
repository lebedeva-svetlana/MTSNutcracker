namespace Nutcracker
{
    public static class Book
    {
        public static List<Character> ActingCharacters = new();

        public static void Narrate()
        {
            Character Godfather = new("Godfather");
            ActingCharacters.Add(Godfather);

            Godfather.FacialExpression.Name = "displeased";
            Godfather.FacialExpression.Power += 10;

            Speech GodfatherSpeech = new()
            {
                IsDirect = true,
                Emotion = new("through clenched teeth"),
                SpeechType = SpeechType.Incentive,
                Tense = Tense.Past,
                ObjectOfSpeech = new()
                {
                    Name = "thing",
                    Characteristic = "stupid"
                }
            };

            Character Advisor = new("Advisor");
            Character Mary = new("Mari")
            {
                Property = new()
                {
                    "dolls",
                    "mamselle Clerchen"
                }
            };

            ActingCharacters.Add(Advisor);
            ActingCharacters.Add(Mary);

            Interaction AdvisorAndMari = new(Advisor, Mary)
            {
                Tense = Tense.Present
            };

            Character Nutcracker = new("Nutcracker");

            using (AdvisorAndMari)
            {
                int AdvisorAndMariHands = Mary.Hands / 2 + Advisor.Hands / 2;

                Advisor.Position = new(1, 0);
                Mary.Position = new(2, 0);

                Speech AdvisorSpeech = new()
                {
                    IsDirect = true,
                    SpeechType = SpeechType.Incentive,
                    Tense = Tense.Future,
                    Emotion = new("seriously")
                    {
                        Power = 10
                    }
                };

                using (AdvisorSpeech)
                {
                    Place MariHead = new("MariHead")
                    {
                        Property = new() { "stupid things" }
                    };

                    AdvisorSpeech.ObjectOfSpeech = new()
                    {
                        Name = $"{Mary.Name}",
                        Action = MariHead.Property.Clear
                    };

                    Character MrDrosselmeyerNephew = new("MrDrosselmeyerNephew");

                    Speech MariPossibleSpeech = new()
                    {
                        IsDirect = false,
                        Emotion = new("confidently"),
                        SpeechType = SpeechType.Incentive,
                        Tense = Tense.Present,
                        ObjectOfSpeech = new()
                        {
                            Name = $"{Nutcracker.Name}",
                            Characteristic = $"{Nutcracker.Name} is {Nutcracker.Name} = {Nutcracker == MrDrosselmeyerNephew}"
                        }
                    };

                    Speech MariRealSpeech = new();

                    if (MariRealSpeech == MariPossibleSpeech)
                    {
                        Place Window = new("Window")
                        {
                            Property = Mary.Property
                        };
                    }
                }
            }

            ActingCharacters.Remove(Godfather);
            ActingCharacters.Remove(Advisor);

            DateTime SomeTime = DateTime.Now.AddDays(new Random().Next(30));

            Mary.Emotions.Add(new Emotion("joy"));
            Mary.Emotions.Add(new Emotion("delight"));
            object MiraclesMarySaw = new();

            Speech MarysThoughts = new()
            {
                ObjectOfSpeech = new()
                {
                    Name = $"{Nutcracker.Name}",
                    Action = Mary.FeelEmotions
                }
            };

            Speech? MarysRealSpeech = true ? MarysRealSpeech = null : MarysRealSpeech = MarysThoughts;

            try
            {
                throw new EmotionException("can't forget");
                Mary.Emotions.Clear();
                MiraclesMarySaw = null;
            }
            catch (EmotionException itsSoHard)
            {
                Mary.FeelEmotions();
            }

            Character You = new("Fritz");
            Character FritzStahlbaum = new("FritzStahlbaum");

            bool AreYouNamesakes = You.Name == FritzStahlbaum.Name.Substring(0, You.Name.Length);

            ActingCharacters.Add(FritzStahlbaum);

            Place Kingdom = new("Kingdom");
            Mary.Emotions.Add(new Emotion("happy") { Power = 10 });

            Interaction MariAndFritzStahlbaum = new(Mary, FritzStahlbaum)
            {
                Tense = Tense.Past
            };

            using (MariAndFritzStahlbaum)
            {
                Speech MarysStories = new();
                {
                    MarysStories.IsDirect = false;
                    MarysStories.Tense = Tense.Past;
                    MarysStories.ObjectOfSpeech = new()
                    {
                        Name = $"{Kingdom.Name}",
                        Characteristic = "beautiful",
                        Action = Mary.FeelEmotions
                    };
                };

                bool DidHeWantListenMary = false;

                Speech FritzStahlbaumSpeech = new()
                {
                    Emotion = new("contemptuously"),
                    IsDirect = false,
                    SpeechType = SpeechType.Incentive,
                    Tense = Tense.Past,
                    ObjectOfSpeech = new()
                    {
                        Name = $"{Mary.Name}",
                        Characteristic = "stupid girl"
                    }
                };

                FritzStahlbaum.Emotions.Add(new Emotion("mistrust") { Power = 10 });

                FritzStahlbaumSpeech.ObjectOfSpeech = new()
                {
                    Name = $"{MarysStories}",
                    Characteristic = "fake"
                };
            }

            ActingCharacters.Remove(Mary);

            DateTime NextArmyParadeDate = DateTime.Now.AddDays(new Random().Next(50));

            Character[] Hussars = new Character[30];
            for (int hussar = 0; hussar < Hussars.Length; ++hussar)
            {
                Hussars[hussar] = new Character($"Hussar №{hussar}");
            }

            Action[]? HussarsPunishment = new Action[Hussars.Length];

            Place FritzStahlbaumArmyParade = new("FritzStahlbaumParade")
            {
                Characters = Hussars
            };

            Interaction FritzStahlbaumAndHussars = new();

            using (FritzStahlbaumAndHussars)
            {
                HussarsPunishment = null;

                foreach (Character hussar in Hussars)
                {
                    hussar.Property = new();
                    hussar.Property.Add("goose feather plume for hat");
                }

                bool CanTheyPlaySolemnMarchAgain = true;
            }
        }
    }
}