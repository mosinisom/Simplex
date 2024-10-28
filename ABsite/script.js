document.getElementById('generate').addEventListener('click', generateMatrix);
document.getElementById('calculate').addEventListener('click', calculate);

let rows, colms, raz_row, raz_col, razr_elem;
let matrix = [];

function generateMatrix() {
    rows = parseInt(document.getElementById('rows').value);
    colms = parseInt(document.getElementById('columns').value);

    if (isNaN(rows) || isNaN(colms) || rows <= 0 || colms <= 0) {
        alert('Введите корректные размеры матрицы');
        return;
    }

    createMatrix('matrix1', rows, colms);
    createMatrix('matrix2', rows, colms);
}

function createMatrix(tableId, rows, colms) {
    const table = document.getElementById(tableId);
    table.innerHTML = '';

    for (let i = 0; i < rows; i++) {
        const row = table.insertRow();
        for (let j = 0; j < colms; j++) {
            const cell = row.insertCell();
            const input = document.createElement('input');
            input.type = 'number';
            input.value = 0;
            cell.appendChild(input);
        }
    }

    // Add headers
    for (let i = 0; i < colms; i++) {
        table.rows[0].cells[i].innerHTML = `<input type="number" value="${i === 0 ? 1 : -i}" readonly>`;
    }
    for (let i = 0; i < rows; i++) {
        table.rows[i].cells[0].innerHTML = `<input type="number" value="${i < rows - 2 ? 'x' + (i + 1 + rows) : i === rows - 2 ? 'f:' : 'g:'}" readonly>`;
    }
}

function calculate() {
    raz_row = parseInt(document.getElementById('raz_row').value);
    raz_col = parseInt(document.getElementById('raz_col').value);

    if (isNaN(raz_row) || isNaN(raz_col) || raz_row < 0 || raz_col < 0 || raz_row >= rows || raz_col >= colms) {
        alert('Введите корректные значения для разрешающей строки и столбца');
        return;
    }

    const matrix1 = getMatrixValues('matrix1');
    const matrix2 = getMatrixValues('matrix2');

    if (!matrix1 || !matrix2) {
        alert('Ошибка! Проверьте корректность данных');
        return;
    }

    razr_elem = matrix1[raz_row][raz_col];
    let spokuha = Array.from(Array(rows), () => new Array(colms));

    // Update headers
    let change_name = matrix1[raz_row][0];
    matrix1[raz_row][0] = matrix1[0][raz_col];
    matrix1[0][raz_col] = change_name;

    for (let i = 0; i < rows; i++) {
        for (let j = 0; j < colms; j++) {
            if (i === raz_row && j === raz_col) {
                spokuha[i][j] = 1 / razr_elem;
            } else if (i === raz_row) {
                spokuha[i][j] = matrix1[raz_row][j] / razr_elem;
            } else if (j === raz_col) {
                spokuha[i][j] = matrix1[i][raz_col] * -1;
            } else {
                spokuha[i][j] = (matrix1[i][j] * razr_elem - matrix1[i][raz_col] * matrix1[raz_row][j]) / razr_elem;
            }
        }
    }

    setMatrixValues('matrix2', spokuha);
    alert('Рассчет выполнен');
}

function getMatrixValues(tableId) {
    const table = document.getElementById(tableId);
    const rows = table.rows.length;
    const colms = table.rows[0].cells.length;
    const matrix = [];

    for (let i = 0; i < rows; i++) {
        const row = [];
        for (let j = 0; j < colms; j++) {
            const value = parseFloat(table.rows[i].cells[j].querySelector('input').value);
            if (isNaN(value)) {
                return null;
            }
            row.push(value);
        }
        matrix.push(row);
    }

    return matrix;
}

function setMatrixValues(tableId, matrix) {
    const table = document.getElementById(tableId);

    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix[i].length; j++) {
            table.rows[i].cells[j].querySelector('input').value = matrix[i][j];
        }
    }
}