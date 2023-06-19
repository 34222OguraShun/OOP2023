using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
                List<Student> students = new List<Student>();
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines) {        //すべての行から一行ずつ取り出す
                    string[] items = line.Split(',');   //区切りで項目別に分ける
                Student student = new Student {             //Studentインスタンス生成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                    };
                    students.Add(student);//Studentインスタンスをコレクションに追加
            }
                return students;
            }

            //メソッドの概要： 
            public IDictionary<string, int> GetPerStudentScore() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Student subject in _score) {
                if (dict.ContainsKey(subject.Subject))
                    dict[subject.Subject] += subject.Score;
                else
                    dict[subject.Subject] = subject.Score;
            }
            return dict;
        
            }       
    }
}
