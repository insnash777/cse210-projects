using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTilte = "Chuck Norris"; //Yes this is a job.
        job1._company = "Chuck Norris"; //Chuck employs a lot of people under the job title of his own name.
        job1._startYear = 1940; //He's been doing it since birth even.
        job1._endYear = 3000; //It's all the same but they live underwater.

        job2._jobTilte = "The kid who bullied you in preschool."; //This is too.
        job2._company = "Self Employed"; //It's a weird job to be honest. Who else would employ you but yourself?
        job2._startYear = 2007; //This was his side hussel.
        job2._endYear = 2008; //It didn't work out because...

        Resume resume1 = new Resume();

        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        resume1.Display();
    }
}