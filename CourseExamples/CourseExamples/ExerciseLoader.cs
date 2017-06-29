using CourseExamples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseExamples
{
    class ExerciseLoader
    {
        static void Main(string[] args)
        {
            var type = typeof(IExercise);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p)).ToList<Type>();
            List<IExercise> exercises = new List<IExercise>();
            foreach(Type TypeEx in types)
            {
                if (TypeEx != typeof(IExercise))
                {
                    exercises.Add((IExercise)Activator.CreateInstance(Type.GetType(TypeEx.ToString())));
                }
            }
            foreach(IExercise ex in exercises)
            {
                ex.Solve();
            }

        }
    }
}
