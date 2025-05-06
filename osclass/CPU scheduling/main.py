import sys
from fcfs import fcfs
from sjf import sjf_non_preemptive
from srtf import srtf
from roundrobin import round_robin

ALGORITHMS = ["fcfs", "sjf", "srtf", "roundrobin"]

def main():
    if len(sys.argv) > 3:
        print("Too many arguments")
        sys.exit()
    
    if len(sys.argv) < 2:
        print()
        print('"Scheduling ALGORITHMS Project"')
        print("[1] - FCFS(First Come First Serve)")
        print("[2] - SJF(Shortest Job First)")
        print("[3] - SRTF/SRTN(Shortest Remaining Time First/Shortest Remaining Time Next)")
        print("[4] - RoundRobin")
        while True:
            algorithm = input("Input algorithm: ").lower()
            if algorithm in ALGORITHMS or (int(algorithm) >= 1 and int(algorithm) <= 4):
                while True:
                    try:
                        process_file = input("Input file: ")
                        if algorithm == ALGORITHMS[0] or algorithm == '1':
                            fcfs(process_file)
                        elif algorithm == ALGORITHMS[1] or algorithm == '2':
                            sjf_non_preemptive(process_file)
                        elif algorithm == ALGORITHMS[2] or algorithm == 'srtn' or algorithm == '3':
                            srtf(process_file)
                        elif algorithm == ALGORITHMS[3] or algorithm == '4':
                            while True:
                                try:
                                    time_quanta = int(input("Input time quanta: "))
                                    break
                                except ValueError:
                                    continue
                            round_robin(process_file, time_quanta)
                        break
                    except FileNotFoundError:
                        print("File not found(File must be have a .txt extension)")
                        continue
                break
            else:
                print(f"Invalid input: input {ALGORITHMS} only")
                continue

    else:
        if sys.argv[1].lower() in ALGORITHMS:
            try:
                process_file = sys.argv[2]
                if sys.argv[1].lower() == ALGORITHMS[0]:
                    fcfs(process_file)
                elif sys.argv[1].lower() == ALGORITHMS[1]:
                    sjf_non_preemptive(process_file)
                elif sys.argv[1].lower() == ALGORITHMS[2] or sys.argv[1].lower() == 'srtn':
                    srtf(process_file)
                elif sys.argv[1].lower() == ALGORITHMS[3]:
                    while True:
                        try:
                            time_quanta = int(input("Input time quanta: "))
                            break
                        except ValueError:
                            continue
                    round_robin(process_file, time_quanta)
            except FileNotFoundError:
                print("\nFile not found (File must be have a .txt extension).\n")
        else:
            print(f"\nInvalid argument: input {ALGORITHMS} only\n")

if __name__ == "__main__":
    main()