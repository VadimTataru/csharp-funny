
//октава
int octave = 2;
int duration = 200;
int[] notes = { 130, 164, 196, 246, 261, 246, 196, 164 }; //до ми соль си до си соль ми =)
int i = 0;

while(true)
{
    Console.Beep(notes[i] * octave, duration);
    i++;
    if (i == notes.Length) i = 0;
}