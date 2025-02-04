extends Node

var contadorGlobal = 0

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	pass

func sumar1Contador() -> void:
	contadorGlobal = contadorGlobal + 1

func getContadorGlobal() -> int:
	return contadorGlobal

func setContadorGlobal( num: int ) ->void:
	contadorGlobal = num
