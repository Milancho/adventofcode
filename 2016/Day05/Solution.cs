using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace AdventOfCode.Y2016.Day05 {

    [ProblemName("How About a Nice Game of Chess?")]
    class Solution : Solver {

        public IEnumerable<object> Solve(string input) {

            // var q = new ConcurrentQueue<int>();
            // for (var i = 0; i < 100; i++) {
            //     Parallel.ForEach(
            //             Enumerable.Range(0, 100000),
            //             () => 42,
            //             (i, state, _) => {
            //                 if (i > 50 && i % 3 == 1) {
            //                     q.Enqueue(i);
            //                     state.Stop();
            //                 }
            //                 return 2;
            //             },
            //             (_) => { }
            //         );

            //     Console.WriteLine(q.Min());
            // }

            yield return PartOne(input);
            yield return PartTwo(input);
        }

        string PartOne(string input) {
            var st = "";
            foreach (var hash in Hashes(input)) {
                st += hash[2].ToString("x");
                if (st.Length == 8) {
                    break;
                }
            }
            return st;
        }

        string PartTwo(string input) {
            var chars = Enumerable.Range(0, 8).Select(_ => (char)255).ToArray();
            var found = 0;
            foreach (var hash in Hashes(input)) {
                if (hash[2] < 8) {
                    var i = hash[2];
                    if (chars[i] == 255) {
                        chars[i] = hash[3].ToString("x2")[0];
                        found++;
                        if (found == 8) {
                            break;
                        }
                    }

                }
            }
            return string.Join("", chars);
        }

        public IEnumerable<byte[]> Hashes(string input) {

            for (var i = 0; i < int.MaxValue; i++) {
                var q = new ConcurrentQueue<(int i, byte[] hash)>();

                Parallel.ForEach(
                    Enumerable.Range(i, int.MaxValue - i),
                    () => MD5.Create(),
                    (i, state, md5) => {
                        var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(input + i));

                        if (hash[0] == 0 && hash[1] == 0 && hash[2] < 16) {
                            q.Enqueue((i, hash));
                            state.Stop();
                        }
                        return md5;
                    },
                    (_) => { }
                );
                var item = q.OrderBy(x => x.i).First();
                i = item.i;
                yield return item.hash;
            }
        }
    }
}