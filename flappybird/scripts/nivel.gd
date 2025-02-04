extends Node2D

var tuberias: PackedScene # Arrastra aquí la escena PipeScene.tscn
var spawn_position: Vector2 = Vector2(450, 200)  # Posición inicial de generación
var min_y: float = 100  # Altura mínima de las tuberías
var max_y: float = 300  # Altura máxima de las tuberías

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	tuberias = load("res://escenas/tuberias.tscn")
	$Timer.timeout.connect(aparecer_laser)
	$Timer.start()
	pass # Replace with function body.

func aparecer_laser():
	var tuberia_instanciada = tuberias.instantiate() 
	var random_y = randf_range(min_y, max_y)  
	tuberia_instanciada.position = Vector2(spawn_position.x, random_y)  
	$laser_aleatorio.add_child(tuberia_instanciada) 

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass
