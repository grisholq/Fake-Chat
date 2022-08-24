public class LiveStreamTimer : Timer
{
    public override void UpdateDisplay()
    {
        int minutes;
        int seconds;

        minutes = (int)(_time / 60f);
        seconds = (int)(_time - minutes * 60);


        ClearDisplay();
        _timeDisplay.text += "LIVE ";
        UpdateMinutes(minutes);
        UpdateSeconds(seconds);
    }
}