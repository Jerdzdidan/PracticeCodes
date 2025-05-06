import statistics

def draw_table(completed):
    print("\nProcess Table:")
    
    keys = list(completed.keys())
    keys.sort()

    tat_list = []
    wt_list = []

    any_three_digits = any(len(str(x)) == 3 for values in completed.values() for x in values)

    format_str = '{:03d}' if any_three_digits else '{:02d}'

    if any_three_digits:
        print("PROCESS ID |  AT |  BT |  ST |  FT | TAT |  WT")
        print("______________________________________________")
    else:
        print("PROCESS ID | AT | BT | ST | FT | TAT | WT")
        print("________________________________________")

    for pid in keys:
        processes = completed[pid]

        at = format_str.format(processes[0])
        bt = format_str.format(processes[1])
        st = format_str.format(processes[2])
        ft = format_str.format(processes[3])
        tat = format_str.format(processes[4])
        wt = format_str.format(processes[5])

        tat_list.append(processes[4])
        wt_list.append(processes[5])

        if any_three_digits:
            print(f"    {pid}     | {at} | {bt} | {st} | {ft} | {tat} | {wt}")
        else:
            print(f"    {pid}     | {at} | {bt} | {st} | {ft} |  {tat} | {wt}")


    ave_tat = statistics.mean(tat_list)
    ave_wt = statistics.mean(wt_list)
    print(f"\nAverage Turnaround Time = {ave_tat:.2f}")
    print(f"Average Waiting Time = {ave_wt:.2f}")
    print()

def draw_gantt_chart(gantt):
    print("Gantt Chart:")
    max_pid_length = max(len(str(pid[0])) for pid in gantt)
    pid_spacing = max(max_pid_length, 3)  
    for pid in gantt:
        process = gantt[pid]
        pid_str2 = str(process[1])
        if len(pid_str2) >= 3:
             print(" ____ ", end=" " * pid_spacing)
        else:
            print(" ____ ", end=" ")
    print()
    for pid in gantt:
        process = gantt[pid]
        pid_str2 = str(process[1])
        if len(pid_str2) >= 3:
            print(f"| {pid} |", end=" " * pid_spacing)
        else:
            print(f"| {pid} |", end=" ")
    print()
    for pid in gantt:
        process = gantt[pid]
        pid_str2 = str(process[1])
        if len(pid_str2) >= 3:
            print(f"|----|", end=" " * pid_spacing)
        else:
            print(f"|----|", end=" ")
    print()
    for pid in gantt:
        process = gantt[pid]
        st = '{:02d}'.format(process[0])
        ft = '{:02d}'.format(process[1])
        print(f"{st}  {ft}", end=" ")
    print()

# Process format = [arrival_time, burst_time, process_id]
def read_process_file(filename):
    process_list = []
    with open(filename, 'r') as file:
        for line in file:
            parts = line.strip().split(',')
            if len(parts) >= 3:  
                process_id = parts[0].strip()
                arrival_time = int(parts[1].strip())
                burst_time = int(parts[2].strip())
                process_list.append([arrival_time, burst_time, process_id])
            else:
                continue
    return process_list

def fcfs(process_file):
    process_list = read_process_file(process_file)
    count = 1
    time = 0
    gantt = {}
    completed = {}

    while process_list:
        process_list.sort(key=lambda x: (x[0], x[2])) 
        process = process_list.pop(0)
        arrival_time = process[0]
        burst_time = process[1]

        if arrival_time > time:
            start_time = time
            time = arrival_time
            finish_time = time
            gantt[f"i{count}"] = [start_time, finish_time]
            count += 1

        start_time = time
        time += burst_time
        pid = process[2]
        finish_time = time

        turn_around_time = finish_time - arrival_time
        waiting_time = turn_around_time - burst_time

        gantt[pid] = [start_time, finish_time]
        completed[pid] = [arrival_time, burst_time, start_time, finish_time, turn_around_time, waiting_time]

    print("\nFirst-Come-First-Serve Algorithm:")
    draw_gantt_chart(gantt)
    draw_table(completed)

if __name__ == "__main__":
    fcfs("processes2.txt")