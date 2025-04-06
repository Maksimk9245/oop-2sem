import readline from 'readline';
import { FormattedRow } from './FormattedRow';

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question('Введіть рядок: ', (input) => {
    const row = new FormattedRow(input);
    row.printInfo();
    rl.close();
});
