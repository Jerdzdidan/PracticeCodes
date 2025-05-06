from roundrobin import draw_gantt_chart, draw_table
from sjf import read_process_file

def srtf(process_file):
    process_list = read_process_file(process_file)
    gantt = []
    burst_times = {p[2]: p[0] for p in process_list}
    completion = {}
    t = 0
    current_process = None
    start_time = 0

    while process_list:
        available = [p for p in process_list if p[1] <= t]
        if not available:
            gantt.append(("Idle", t, t + 1))
            t += 1
            continue
        else:
            shortest_remaining = min(available, key=lambda x: x[0])
            pid = shortest_remaining[2]
            if pid != current_process:
                if current_process is not None:
                    gantt.append([current_process, start_time, t])
                start_time = t
                current_process = pid
            t += 1
            shortest_remaining[0] -= 1
            if shortest_remaining[0] == 0:
                arrival_time = shortest_remaining[1]
                burst_time = burst_times[pid]
                ct = t
                tt = ct - arrival_time
                wt = tt - burst_time
                completion[pid] = [arrival_time, burst_time, start_time, ct, tt, wt]
                process_list.remove(shortest_remaining)

    if current_process is not None:
        gantt.append([current_process, start_time, t])

    print("\nShortest Time First/Shortest Time Next Algorithm:")
    draw_gantt_chart(gantt)
    draw_table(completion, gantt)
        

if __name__ == "__main__":
    srtf("srtf.txt")