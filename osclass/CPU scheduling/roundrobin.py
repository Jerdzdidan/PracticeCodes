import statistics
from fcfs import read_process_file

def round_robin(process_file, time_quanta):
    process_list = read_process_file(process_file)
    t = 0
    gantt = []
    completed = {}
    process_order = []

    # Sort the processes by arrival time and then by process ID
    process_list.sort(key=lambda x: (x[0], x[2]))

    burst_times = {}
    for p in process_list:
        pid = p[2]
        burst_time = p[1]
        burst_times[pid] = burst_time

    while process_list:
        available = [p for p in process_list if p[0] <= t]

        if not available:
            gantt.append(("Idle", t, t + 1))
            t += 1
            continue
        else:
            process = available[0]
            pid = process[2]
            start_time = max(t, process[0])
            process_list.remove(process)
            rem_burst = process[1]

            if rem_burst <= time_quanta:
                t = start_time + rem_burst
                ct = t
                arrival_time = process[0]
                burst_time = burst_times[pid]
                tt = ct - arrival_time
                wt = tt - burst_time
                completed[pid] = [arrival_time, burst_time, start_time, t, tt, wt]
                gantt.append((pid, start_time, t))
            else:
                t = start_time + time_quanta
                process[1] -= time_quanta
                process_list.append(process)
                gantt.append((pid, start_time, t))

    print("\nRound Robin Algorithm:")
    draw_gantt_chart(gantt)
    draw_table(completed, gantt)

def draw_gantt_chart(gantt):
    print("Gantt Chart:")
    max_pid_length = max(len(str(pid[0])) for pid in gantt)
    pid_spacing = max(max_pid_length, 3)  

    for pid in gantt:
        pid_str2 = str(pid[2])
        if len(pid_str2) >= 3:
            print("  ____ ", end=" " * pid_spacing)
        else:
            print("  ____ ", end=" ")
    print()
    for pid in gantt:
        pid_str2 = str(pid[2])
        if len(pid_str2) >= 3:
            print(f" | {pid[0]} |", end=" " * pid_spacing)
        else:
            print(f" | {pid[0]} |", end=" ")
    print()
    for pid in gantt:
        pid_str2 = str(pid[2])
        if len(pid_str2) >= 3:
            print(f" |----|", end=" " * pid_spacing)
        else:
            print(f" |----|", end=" ")
    print()
    for pid in gantt:
        st = '{:02d}'.format(pid[1])
        ft = '{:02d}'.format(pid[2])
        st_spacing = " " * (3 - len(st)) if len(st) >= 3 else ""
        ft_spacing = " " * (3 - len(ft)) if len(ft) >= 3 else ""
        print(f" {st_spacing}{st}  {ft_spacing}{ft}", end=" ")
    print()





def draw_table(completed, gantt):
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

        for entry in gantt:
            if entry[0] == pid:
                processes[2] = entry[1]
                break

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

if __name__ == "__main__":
    time_quanta = 5
    round_robin("roundrobin.txt", time_quanta)
