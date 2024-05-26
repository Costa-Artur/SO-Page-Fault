const size = 100000000;

let array: number[] = new Array(size).fill(0);

for (let i = 0; i < size; i++) {
    array[i] = Math.floor(Math.random() * 100);
}

let sum = 0;
for (let j = 0; j < 100; j++) {
    for (let i = 0; i < size; i++) {
        sum += array[i];
    }
}

console.log("Soma:", sum);
