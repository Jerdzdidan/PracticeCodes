from fcfs import draw_table, draw_gantt_chart

# Process format = [burst_time, arrival_time, process_id]
def read_process_file(filename):
    process_list = []
    with open(filename, 'r') as file:
        for line in file:
            parts = line.strip().split(',')
            if len(parts) >= 3:  
                process_id = parts[0].strip()
                arrival_time = int(parts[1].strip())
                burst_time = int(parts[2].strip())
                process_list.append([burst_time, arrival_time, process_id])
            else:
                continue
    return process_list

def sjf_non_preemptive(process_file):
    process_list = read_process_file(process_file)
    count = 1
    time = 0
    gantt = {}
    completed = {}

    while process_list:
        available = [process for process in process_list if process[1] <= time]
        
        if not available:
            next_arrival = min(process[1] for process in process_list)
            start_time = time
            time = next_arrival
            finish_time = time
            gantt[f"i{count}"] = [start_time, finish_time]
            count += 1
            continue
        
        available.sort()
        process = available[0]

        pid = process[2]
        arrival_time = process[1]
        burst_time = process[0]

        start_time = time
        time += burst_time
        finish_time = time

        turn_around_time = finish_time - arrival_time
        waiting_time = turn_around_time - burst_time

        process_list.remove(process)

        gantt[pid] = [start_time, finish_time]
        completed[pid] = [arrival_time, burst_time, start_time, finish_time, turn_around_time, waiting_time]

    print("\nShortest-Job-First Algorithm:")
    draw_gantt_chart(gantt)
    draw_table(completed)


if __name__ == "__main__":
    sjf_non_preemptive("sjf.txt")
