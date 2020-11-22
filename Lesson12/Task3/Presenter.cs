using System;

namespace Task3
{
    class Presenter
    {
        private Model _model;
        private MainWindow _view;
        public Presenter(MainWindow view)
        {
            _model = new Model();
            _view = view;
            _view.Start += _view_Start;
            _view.Reset += _view_Reset;
            _view.Stop += _view_Stop;
            _view.timer.Tick += Timer_Tick;
            _view.timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
        }
        private void _view_Stop(object sender, EventArgs e)
        {
            _view.timer.Stop();
        }

        private void _view_Reset(object sender, EventArgs e)
        {
            _view.timer.Stop();
            _view.Seconds.Content = "0 мин 0 сек";
            _model.Reset();
        }

        private void _view_Start(object sender, EventArgs e)
        {
            _view.timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _view.Seconds.Content = _model.Tick();
        }
    }
}
