namespace ExerciseTracker
{
    class Running : Activity
    {
        private double _distance;
        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / base._minutes) * 60.0;
        }

        public override double GetPace()
        {
            return base._minutes / _distance;
        }

    }
}