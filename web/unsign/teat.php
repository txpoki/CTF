<?php
class car {
    public $brand;
    public $modle;
    public $color;

    public function start()
    {
        echo "started";
    }
    public function accel()
    {
        echo "accel";
    }
    public function stop()
    {
        echo "stop";
    }
}
class electiccar extends car
{
    public $battery;
    public function charge()
    {
        echo "charging~";
    }
}

$vauleCar = new car();
$vauleCar  ->brand = "vaule";
$vauleCar ->modle = "Car";
$vauleCar -> color = "black";

$vauleCar -> start();
$vauleCar -> accel();
$vauleCar -> stop();

echo $vauleCar->brand;