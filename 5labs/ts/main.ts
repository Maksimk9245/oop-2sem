import Triangle from './triangle';
import Figure from './figure';

function showFigureInfo(figure: Figure): void {
  figure.print();
}

const figures: Figure[] = [
  new Triangle(0, 0, 3, 0, 0, 4),
  new Triangle(1, 1, 4, 1, 1, 5),
];

for (const figure of figures) {
  showFigureInfo(figure);
}
