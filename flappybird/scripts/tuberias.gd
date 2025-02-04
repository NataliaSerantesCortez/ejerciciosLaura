extends Node2D

var speed = -200
# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	##$areaPuntos.add_to_group("puntos")
	pass # Replace with function body.

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	position.x += speed * delta
	
	if position.x < -700:
		queue_free()
	pass

func _on_area_2d_body_entered(body: Node2D) -> void:
	if body.is_in_group("marciano"):
		show_game_over_menu()
	pass # Replace with function body.

func show_game_over_menu():	
	get_tree().change_scene_to_file("res://escenas/menuDerrota.tscn")

func _on_area_puntos_body_exited(body: Node2D) -> void:
	if body.is_in_group("marciano"):
		Controlador.sumar1Contador()
	pass # Replace with function body.
	
	
