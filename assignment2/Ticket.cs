using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Ticket
    {
        private string _movieName;
        private int _cinemaRoom;
        private int _minimumAge;
        private DateTime _startTime;

        public string MovieName
        {
            get => _movieName;
            set
            {
                if (!value.Equals(""))
                {
                    _movieName = value;
                }
                else
                {
                    throw new Exception("Movie name cannot be empty");
                }
            }
        }

        public int CinemaRoom
        {
            get => _cinemaRoom;
            set
            {
                int[] rooms = new int[] {1, 2, 3, 4, 5};
                if (rooms.Contains(value))
                {
                    _cinemaRoom = value;
                }
                else
                {
                    throw new Exception($"Invalid cinema room {value}");
                }
            }
        }

        public DateTime StartTime
        {
            get => _startTime;
            set
            {
                if (value.Minute % 30 == 0)
                {
                    _startTime = value;
                }
                else
                {
                    throw new Exception(
                        $"Invalid start time :{value.TimeOfDay.ToString()}. Must start on hour or half hour");
                }
            }
        }

        public decimal Price { get; set; }

        public int MinimumAge
        {
            get => _minimumAge;
            set
            {
                int[] ratings = new int[] {0, 6, 9, 12, 16};
                if (ratings.Contains(value))
                {
                    _minimumAge = value;
                }
                else
                {
                    throw new Exception($"Invalid rating {value}");
                }
            }
        }

        public bool Discount
        {
            get
            {
                if (StartTime.DayOfWeek == DayOfWeek.Tuesday || StartTime.DayOfWeek == DayOfWeek.Monday)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Ticket(string movieName, decimal price)
        {
            this.MovieName = movieName;
            this.Price = price;
        }
    }
}